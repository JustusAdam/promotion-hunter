namespace PromotionHunter

module MainWindow = 
    open System
    open Gtk
    
    type MyWindow() as this = 
        inherit Window("MainWindow")

        do this.Title <- "Testapplication"

        let label1 = new Label()

        do label1.Text <- "content"

        let fillMe(homogen, spacing, expand, fill, padding) = 

            let box = new VBox(homogen, spacing)
            this.SetDefaultSize(400, 300)
            this.DeleteEvent.AddHandler(fun o e -> this.OnDeleteEvent(o, e))

            box.PackStart(label1, expand, fill, padding)

            let button1 = new Button("Submit")
            button1.Clicked.AddHandler(fun o e -> this.btn_click(o, e))
            let box2 = new HBox(homogen, spacing)
            box2.PackEnd(button1)
            box2.PackStart(new HBox(), true, true, uint32 1)
            box.PackEnd(box2, expand, false, padding)

            this.Add(box)


        do fillMe(false, 20, false, false, uint32 60)
        do this.ShowAll()

        member this.btn_click (o,e : EventArgs) =
            label1.Text <- "submitted"

        member this.OnDeleteEvent(o, e : DeleteEventArgs) = 
            Application.Quit()
            e.RetVal <- true
        
        