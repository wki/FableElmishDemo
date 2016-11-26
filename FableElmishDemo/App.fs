namespace FableElmishDemo

module App =
    open Elmish

    // Model
    type Model = {
        page: string
    }

    type Msg =
    | Sample

    // Init (ignore argument but generate an initial )
    let init _ = { page = "empty" }, Cmd.ofMsg Sample

    // Update
    let update msg model =
        match msg with
        | Sample -> model, []

    // View
    open Fable.Helpers.React
    open Fable.Helpers.React.Props
    
    let view model (dispatch: Dispatch<Msg>) =
        div []
            [ unbox "Hello world!"]


    // App
    open Elmish.React

    Program.mkProgram init update view
    |> Program.withConsoleTrace
    |> Program.toHtml Program.run "elmish-app"