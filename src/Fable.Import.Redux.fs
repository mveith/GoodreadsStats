module Fable.Import.Redux

open Fable.Core.JsInterop
open Fable.Import

type IStore<'TState, 'TAction> =
    abstract dispatch: 'TAction->unit
    abstract subscribe: (unit->unit)->unit
    abstract getState: unit->'TState

let private createStore_: JsFunc = import "createStore" "redux"

let createStore (reducer: 'TState->'TAction->'TState) (initState: 'TState): IStore<'TState, 'TAction> =
    // Check if the action is a lifecycle event dispatched by Redux before applying the reducer
    let jsReducer =
        fun state action ->
            match !!action?``type``: obj with
            | :?string as s when s.StartsWith "@@" -> state
            | _ -> reducer state action
    match !!Browser.window?devToolsExtension: JsFunc with
    | null -> !!createStore_.Invoke(jsReducer, initState)
    | ext -> !!createStore_.Invoke(jsReducer, initState, ext.Invoke())