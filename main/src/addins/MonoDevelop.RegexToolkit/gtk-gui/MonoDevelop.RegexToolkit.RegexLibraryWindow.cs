// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.RegexToolkit {
    
    
    public partial class RegexLibraryWindow {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label7;
        
        private Gtk.Entry searchEntry;
        
        private Gtk.VPaned vpaned1;
        
        private Gtk.VBox vbox6;
        
        private Gtk.Label label8;
        
        private Gtk.ScrolledWindow scrolledwindow2;
        
        private Gtk.TreeView expressionsTreeview;
        
        private Gtk.VBox vbox3;
        
        private Gtk.Table table2;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Entry authorEntry;
        
        private Gtk.Label label6;
        
        private Gtk.Entry sourceEntry;
        
        private Gtk.Label label3;
        
        private Gtk.Label label5;
        
        private Gtk.Entry patternEntry;
        
        private Gtk.VBox vbox7;
        
        private Gtk.Label label9;
        
        private Gtk.ScrolledWindow scrolledwindow1;
        
        private Gtk.TextView descriptionTextview;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Entry matchingEntry;
        
        private Gtk.Label label2;
        
        private Gtk.Entry nonMatchingEntry;
        
        private Gtk.HButtonBox hbuttonbox2;
        
        private Gtk.Button buttonCancel;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.RegexToolkit.RegexLibraryWindow
            this.Name = "MonoDevelop.RegexToolkit.RegexLibraryWindow";
            this.Title = Mono.Unix.Catalog.GetString("Regex Library");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.BorderWidth = ((uint)(6));
            // Container child MonoDevelop.RegexToolkit.RegexLibraryWindow.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(6));
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label7 = new Gtk.Label();
            this.label7.Name = "label7";
            this.label7.LabelProp = Mono.Unix.Catalog.GetString("Search:");
            this.hbox4.Add(this.label7);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.hbox4[this.label7]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child hbox4.Gtk.Box+BoxChild
            this.searchEntry = new Gtk.Entry();
            this.searchEntry.CanFocus = true;
            this.searchEntry.Name = "searchEntry";
            this.searchEntry.IsEditable = true;
            this.searchEntry.InvisibleChar = '●';
            this.hbox4.Add(this.searchEntry);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox4[this.searchEntry]));
            w2.Position = 1;
            this.vbox2.Add(this.hbox4);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vpaned1 = new Gtk.VPaned();
            this.vpaned1.CanFocus = true;
            this.vpaned1.Name = "vpaned1";
            this.vpaned1.Position = 170;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox6 = new Gtk.VBox();
            this.vbox6.Name = "vbox6";
            this.vbox6.Spacing = 6;
            // Container child vbox6.Gtk.Box+BoxChild
            this.label8 = new Gtk.Label();
            this.label8.Name = "label8";
            this.label8.Xalign = 0F;
            this.label8.LabelProp = Mono.Unix.Catalog.GetString("Expressions");
            this.vbox6.Add(this.label8);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox6[this.label8]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox6.Gtk.Box+BoxChild
            this.scrolledwindow2 = new Gtk.ScrolledWindow();
            this.scrolledwindow2.CanFocus = true;
            this.scrolledwindow2.Name = "scrolledwindow2";
            this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow2.Gtk.Container+ContainerChild
            this.expressionsTreeview = new Gtk.TreeView();
            this.expressionsTreeview.CanFocus = true;
            this.expressionsTreeview.Name = "expressionsTreeview";
            this.expressionsTreeview.HeadersClickable = true;
            this.scrolledwindow2.Add(this.expressionsTreeview);
            this.vbox6.Add(this.scrolledwindow2);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox6[this.scrolledwindow2]));
            w6.Position = 1;
            this.vpaned1.Add(this.vbox6);
            Gtk.Paned.PanedChild w7 = ((Gtk.Paned.PanedChild)(this.vpaned1[this.vbox6]));
            w7.Resize = false;
            // Container child vpaned1.Gtk.Paned+PanedChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.table2 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
            this.table2.Name = "table2";
            this.table2.RowSpacing = ((uint)(6));
            this.table2.ColumnSpacing = ((uint)(6));
            // Container child table2.Gtk.Table+TableChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.authorEntry = new Gtk.Entry();
            this.authorEntry.CanFocus = true;
            this.authorEntry.Name = "authorEntry";
            this.authorEntry.IsEditable = false;
            this.authorEntry.InvisibleChar = '●';
            this.hbox3.Add(this.authorEntry);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox3[this.authorEntry]));
            w8.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.label6 = new Gtk.Label();
            this.label6.Name = "label6";
            this.label6.LabelProp = Mono.Unix.Catalog.GetString("Source:");
            this.hbox3.Add(this.label6);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox3[this.label6]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.sourceEntry = new Gtk.Entry();
            this.sourceEntry.CanFocus = true;
            this.sourceEntry.Name = "sourceEntry";
            this.sourceEntry.IsEditable = false;
            this.sourceEntry.InvisibleChar = '●';
            this.hbox3.Add(this.sourceEntry);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.hbox3[this.sourceEntry]));
            w10.Position = 2;
            this.table2.Add(this.hbox3);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table2[this.hbox3]));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Pattern:");
            this.table2.Add(this.label3);
            Gtk.Table.TableChild w12 = ((Gtk.Table.TableChild)(this.table2[this.label3]));
            w12.TopAttach = ((uint)(1));
            w12.BottomAttach = ((uint)(2));
            w12.XOptions = ((Gtk.AttachOptions)(4));
            w12.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("Author:");
            this.table2.Add(this.label5);
            Gtk.Table.TableChild w13 = ((Gtk.Table.TableChild)(this.table2[this.label5]));
            w13.XOptions = ((Gtk.AttachOptions)(4));
            w13.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table2.Gtk.Table+TableChild
            this.patternEntry = new Gtk.Entry();
            this.patternEntry.CanFocus = true;
            this.patternEntry.Name = "patternEntry";
            this.patternEntry.IsEditable = false;
            this.patternEntry.InvisibleChar = '●';
            this.table2.Add(this.patternEntry);
            Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table2[this.patternEntry]));
            w14.TopAttach = ((uint)(1));
            w14.BottomAttach = ((uint)(2));
            w14.LeftAttach = ((uint)(1));
            w14.RightAttach = ((uint)(2));
            w14.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox3.Add(this.table2);
            Gtk.Box.BoxChild w15 = ((Gtk.Box.BoxChild)(this.vbox3[this.table2]));
            w15.Position = 0;
            w15.Expand = false;
            w15.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.vbox7 = new Gtk.VBox();
            this.vbox7.Name = "vbox7";
            this.vbox7.Spacing = 6;
            // Container child vbox7.Gtk.Box+BoxChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.Xalign = 0F;
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("Description");
            this.vbox7.Add(this.label9);
            Gtk.Box.BoxChild w16 = ((Gtk.Box.BoxChild)(this.vbox7[this.label9]));
            w16.Position = 0;
            w16.Expand = false;
            w16.Fill = false;
            // Container child vbox7.Gtk.Box+BoxChild
            this.scrolledwindow1 = new Gtk.ScrolledWindow();
            this.scrolledwindow1.CanFocus = true;
            this.scrolledwindow1.Name = "scrolledwindow1";
            this.scrolledwindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child scrolledwindow1.Gtk.Container+ContainerChild
            this.descriptionTextview = new Gtk.TextView();
            this.descriptionTextview.CanFocus = true;
            this.descriptionTextview.Name = "descriptionTextview";
            this.descriptionTextview.Editable = false;
            this.descriptionTextview.CursorVisible = false;
            this.descriptionTextview.WrapMode = ((Gtk.WrapMode)(2));
            this.scrolledwindow1.Add(this.descriptionTextview);
            this.vbox7.Add(this.scrolledwindow1);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.vbox7[this.scrolledwindow1]));
            w18.Position = 1;
            this.vbox3.Add(this.vbox7);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox3[this.vbox7]));
            w19.Position = 1;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Matching:");
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w20.Position = 0;
            w20.Expand = false;
            w20.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.matchingEntry = new Gtk.Entry();
            this.matchingEntry.CanFocus = true;
            this.matchingEntry.Name = "matchingEntry";
            this.matchingEntry.IsEditable = false;
            this.matchingEntry.InvisibleChar = '●';
            this.hbox1.Add(this.matchingEntry);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.hbox1[this.matchingEntry]));
            w21.Position = 1;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Non Matching:");
            this.hbox1.Add(this.label2);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox1[this.label2]));
            w22.Position = 2;
            w22.Expand = false;
            w22.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.nonMatchingEntry = new Gtk.Entry();
            this.nonMatchingEntry.CanFocus = true;
            this.nonMatchingEntry.Name = "nonMatchingEntry";
            this.nonMatchingEntry.IsEditable = false;
            this.nonMatchingEntry.InvisibleChar = '●';
            this.hbox1.Add(this.nonMatchingEntry);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox1[this.nonMatchingEntry]));
            w23.Position = 3;
            this.vbox3.Add(this.hbox1);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
            w24.Position = 2;
            w24.Expand = false;
            w24.Fill = false;
            this.vpaned1.Add(this.vbox3);
            this.vbox2.Add(this.vpaned1);
            Gtk.Box.BoxChild w26 = ((Gtk.Box.BoxChild)(this.vbox2[this.vpaned1]));
            w26.Position = 1;
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbuttonbox2 = new Gtk.HButtonBox();
            this.hbuttonbox2.Name = "hbuttonbox2";
            this.hbuttonbox2.Spacing = 6;
            this.hbuttonbox2.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.buttonCancel = new Gtk.Button();
            this.buttonCancel.CanFocus = true;
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseStock = true;
            this.buttonCancel.UseUnderline = true;
            this.buttonCancel.Label = "gtk-close";
            this.hbuttonbox2.Add(this.buttonCancel);
            Gtk.ButtonBox.ButtonBoxChild w27 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.buttonCancel]));
            w27.Expand = false;
            w27.Fill = false;
            // Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-refresh";
            this.hbuttonbox2.Add(this.buttonOk);
            Gtk.ButtonBox.ButtonBoxChild w28 = ((Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.buttonOk]));
            w28.Position = 1;
            w28.Expand = false;
            w28.Fill = false;
            this.vbox2.Add(this.hbuttonbox2);
            Gtk.Box.BoxChild w29 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbuttonbox2]));
            w29.Position = 2;
            w29.Expand = false;
            w29.Fill = false;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 526;
            this.DefaultHeight = 508;
            this.Show();
        }
    }
}
