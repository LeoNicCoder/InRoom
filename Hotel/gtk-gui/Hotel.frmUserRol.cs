
// This file has been generated by the GUI designer. Do not modify.
namespace Hotel
{
    public partial class frmUserRol
    {
        private global::Gtk.Fixed fixed1;

        private global::Gtk.Label lblUserRol;

        private global::Gtk.Label lblUser;

        private global::Gtk.ComboBox cbxUser;

        private global::Gtk.Label lblRol;

        private global::Gtk.ComboBox cbxRol;

        private global::Gtk.ScrolledWindow GtkScrolledWindow;

        private global::Gtk.TreeView tvwUserRol;

        private global::Gtk.Button btnAsignar;

        private global::Gtk.Button btnEliminar;

        protected virtual void Build()
        {
            global::Stetic.Gui.Initialize(this);
            // Widget Hotel.frmUserRol
            this.Name = "Hotel.frmUserRol";
            this.Title = global::Mono.Unix.Catalog.GetString("frmUserRol");
            this.WindowPosition = ((global::Gtk.WindowPosition)(4));
            // Container child Hotel.frmUserRol.Gtk.Container+ContainerChild
            this.fixed1 = new global::Gtk.Fixed();
            this.fixed1.Name = "fixed1";
            this.fixed1.HasWindow = false;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.lblUserRol = new global::Gtk.Label();
            this.lblUserRol.Name = "lblUserRol";
            this.lblUserRol.LabelProp = global::Mono.Unix.Catalog.GetString("Asignar Rol a Usuario");
            this.fixed1.Add(this.lblUserRol);
            global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblUserRol]));
            w1.X = 245;
            w1.Y = 5;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.lblUser = new global::Gtk.Label();
            this.lblUser.Name = "lblUser";
            this.lblUser.LabelProp = global::Mono.Unix.Catalog.GetString("Usuario:");
            this.fixed1.Add(this.lblUser);
            global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblUser]));
            w2.X = 28;
            w2.Y = 60;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.cbxUser = global::Gtk.ComboBox.NewText();
            this.cbxUser.WidthRequest = 200;
            this.cbxUser.Name = "cbxUser";
            this.fixed1.Add(this.cbxUser);
            global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cbxUser]));
            w3.X = 93;
            w3.Y = 50;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.lblRol = new global::Gtk.Label();
            this.lblRol.Name = "lblRol";
            this.lblRol.LabelProp = global::Mono.Unix.Catalog.GetString("Rol:");
            this.fixed1.Add(this.lblRol);
            global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblRol]));
            w4.X = 383;
            w4.Y = 60;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.cbxRol = global::Gtk.ComboBox.NewText();
            this.cbxRol.WidthRequest = 200;
            this.cbxRol.Name = "cbxRol";
            this.fixed1.Add(this.cbxRol);
            global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cbxRol]));
            w5.X = 418;
            w5.Y = 50;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
            this.GtkScrolledWindow.WidthRequest = 550;
            this.GtkScrolledWindow.HeightRequest = 250;
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.tvwUserRol = new global::Gtk.TreeView();
            this.tvwUserRol.CanFocus = true;
            this.tvwUserRol.Name = "tvwUserRol";
            this.GtkScrolledWindow.Add(this.tvwUserRol);
            this.fixed1.Add(this.GtkScrolledWindow);
            global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.GtkScrolledWindow]));
            w7.X = 43;
            w7.Y = 166;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.btnAsignar = new global::Gtk.Button();
            this.btnAsignar.CanFocus = true;
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.UseUnderline = true;
            this.btnAsignar.Label = global::Mono.Unix.Catalog.GetString("Asignar Rol a Usuario");
            this.fixed1.Add(this.btnAsignar);
            global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnAsignar]));
            w8.X = 207;
            w8.Y = 110;
            // Container child fixed1.Gtk.Fixed+FixedChild
            this.btnEliminar = new global::Gtk.Button();
            this.btnEliminar.CanFocus = true;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseUnderline = true;
            this.btnEliminar.Label = global::Mono.Unix.Catalog.GetString("Eliminar Rol a Usuario");
            this.fixed1.Add(this.btnEliminar);
            global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnEliminar]));
            w9.X = 384;
            w9.Y = 110;
            this.Add(this.fixed1);
            if ((this.Child != null))
            {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 628;
            this.DefaultHeight = 421;
            this.Show();
            this.tvwUserRol.CursorChanged += new global::System.EventHandler(this.OnTvwUserRolCursorChanged);
            this.btnAsignar.Clicked += new global::System.EventHandler(this.OnBtnAsignarClicked);
            this.btnEliminar.Clicked += new global::System.EventHandler(this.OnBtnEliminarClicked);
        }
    }
}
