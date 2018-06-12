module Settings.View

open Fable.Core
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let root model dispatch = 
    div
        [ ]
        [ p
            [ ClassName "control" ]
            [ input
                [ ClassName "input"
                  Type "text"
                  Placeholder "Type your name"
                  DefaultValue model.StationUri
                  AutoFocus true
                  OnChange (fun ev -> !!ev.target?value |> ChangeStationUri |> dispatch ) ] ]
          br [ ]
          span
            [ ]
            [ str (sprintf "Hello %s" model.StationUri) ] ]