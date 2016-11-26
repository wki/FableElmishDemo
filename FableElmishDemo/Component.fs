namespace FableElmishDemo

module Component =
    open Elmish

    // Model
    type Model = {
        state: string
    }

    type Msg =
    | Load
    | Loaded
    | Failed

    let init() = { state = "initialized" }, Cmd.ofMsg Load


    // Update
    let update msg model =
        match msg with
        | Load -> { model with state = "loading" }, Cmd.ofMsg Loaded
        | Loaded -> { model with state = "loaded" }, Cmd.none
        | Failed -> { model with state = "failed" }, Cmd.none


    // View
    open Fable.Helpers.React
    open Fable.Helpers.React.Props

    let view model dispatch =
        div []
            [
                h2 []
                   [ unbox "Component" ]
                p [ OnClick (fun _ -> Failed |> dispatch) ]
                  [ unbox (sprintf "State: %s -- click me!" model.state) ]
            ]
