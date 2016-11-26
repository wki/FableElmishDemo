namespace FableElmishDemo

module App =
    open Elmish
    open Component

    // Model
    type Model = {
        page: string
        comp: Component.Model
    }

    type Msg =
    | Sample
    | Comp of Component.Msg

    // Init (ignore argument but generate an initial )
    let init _ =
        let compResult, compCommands = Component.init()
        { 
            page = "empty" 
            comp = compResult
        },
        Cmd.batch [Cmd.ofMsg Sample
                   Cmd.map Comp compCommands]

    // Update
    let update msg model =
        match msg with
        | Sample -> model, []
        | Comp c -> 
            let result,cmds = Component.update c model.comp
            { model with comp = result }, Cmd.map Comp cmds

    // View
    open Fable.Helpers.React
    open Fable.Helpers.React.Props
    
    let view model (dispatch: Dispatch<Msg>) =
        div []
            [ 
                h1 []
                   [ unbox "Hello world!" ]

                Component.view model.comp (Comp >> dispatch)
            ]


    // App
    open Elmish.React

    Program.mkProgram init update view
    |> Program.withConsoleTrace
    |> Program.toHtml Program.run "elmish-app"