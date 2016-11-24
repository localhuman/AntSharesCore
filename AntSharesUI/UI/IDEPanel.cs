using AntShares.Properties;
using ICSharpCode.AvalonEdit;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;

namespace AntShares.UI
{
    public partial class IDEPanel : UserControl
    {
        static IDEPanel()
        {
            using (StringReader sr = new StringReader(Resources.AIL))
            using (XmlReader xr = XmlReader.Create(sr))
            {
                IHighlightingDefinition hd = HighlightingLoader.Load(xr, HighlightingManager.Instance);
                HighlightingManager.Instance.RegisterHighlighting(hd.Name, new[] { "a" }, hd);
            }
        }

        public IDEPanel()
        {
            InitializeComponent();
            TextEditor editor = new TextEditor();
            editor.FontFamily = new FontFamily("Lucida Console");
            editor.Options.HighlightCurrentLine = true;
            editor.ShowLineNumbers = true;
            editor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition("AIL");
            elementHost1.Child = editor;
        }
    }
}
