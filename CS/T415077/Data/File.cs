namespace T415077.Data {
    public class File {
        [System.ComponentModel.Editor(typeof(UIEditors.FilteredFileNameEditor),
          typeof(System.Drawing.Design.UITypeEditor))]
        public string Path { get; set; }
        public string Path2 { get; set; }
    }
}
