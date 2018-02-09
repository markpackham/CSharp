using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;

namespace DocumentAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            GenerateDoc();
        }

        private string createdFile = "E:\\xampp\\htdocs\\CSharp\\DocumentAPI\\CreatedFile\\test.xaml";

        private void MyCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get a reference to the calendar
            var calendar = sender as Calendar;

            // Check that it has a value 
            if (calendar.SelectedDate.HasValue)
            {
                // Display the date
                DateTime date = calendar.SelectedDate.Value;

                try
                {
                    tbDateSelected.Text = date.ToShortDateString();
                }
                catch (NullReferenceException)
                {
                    // Needed for a bug that is triggered during
                    // initialization or you end up with this System.NullReferenceException: 'Object reference not set to an instance of an object.'
                }

            }

        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            // Get a reference to the radiobutton
            var radiobutton = sender as RadioButton;

            // Get the radiobutton pressed
            string radioBPressed = radiobutton.Content.ToString();

            // Change settings based on button
            if (radioBPressed == "Draw")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
            }
            else if (radioBPressed == "Erase")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }
            else if (radioBPressed == "Select")
            {
                this.DrawingCanvas.EditingMode = InkCanvasEditingMode.Select;
            }
        }

        private void DrawPanel_KeyUp(object sender, KeyEventArgs e)
        {
            if ((int)e.Key >= 35 && (int)e.Key <= 68)
            {
                switch ((int)e.Key)
                {
                    case 35:
                        strokeAttr.Width = 2;
                        strokeAttr.Height = 2;
                        break;
                    case 36:
                        strokeAttr.Width = 4;
                        strokeAttr.Height = 4;
                        break;
                    case 37:
                        strokeAttr.Width = 6;
                        strokeAttr.Height = 6;
                        break;
                    case 38:
                        strokeAttr.Width = 8;
                        strokeAttr.Height = 8;
                        break;
                    case 39:
                        strokeAttr.Width = 10;
                        strokeAttr.Height = 10;
                        break;
                    case 40:
                        strokeAttr.Width = 12;
                        strokeAttr.Height = 12;
                        break;
                    case 41:
                        strokeAttr.Width = 14;
                        strokeAttr.Height = 14;
                        break;
                    case 42:
                        strokeAttr.Width = 16;
                        strokeAttr.Height = 16;
                        break;
                    case 43:
                        strokeAttr.Width = 18;
                        strokeAttr.Height = 18;
                        break;
                    case 45:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Blue");
                        break;
                    case 50:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Green");
                        break;
                    case 68:
                        strokeAttr.Color = (Color)ColorConverter.ConvertFromString("Yellow");
                        break;
                }
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("MyPicture.bin", FileMode.Create))
            {
                this.DrawingCanvas.Strokes.Save(fs);
            }
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("MyPicture.bin", FileMode.Open, FileAccess.Read))
            {
                StrokeCollection sc = new StrokeCollection(fs);
                this.DrawingCanvas.Strokes = sc;
            }
        }

        //This is called in public MainWindow() near the very top of the .cs file
        private void GenerateDoc()
        {
            FlowDocument doc = new FlowDocument();

            Paragraph para = new Paragraph(new Run("Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"));
            doc.Blocks.Add(para);

            para = new Paragraph(new Run("Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?"))
            {
                FontSize = 24,
                FontStyle = FontStyles.Italic,
                FontFamily = new FontFamily("Comic Sans MS"),
                Foreground = Brushes.Green
            };
            doc.Blocks.Add(para);

            fdScrollViewer.Document = doc;
        }

        // A ContextMenu displays Cut, Copy and Paste commands
        private void RichTB_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            // Convert to a RichTextBox and check for null
            RichTextBox rtb = sender as RichTextBox;
            if (rtb == null) return;

            // Create ContextMenu
            ContextMenu contextMenu = rtb.ContextMenu;
            contextMenu.PlacementTarget = rtb;

            // This will place the menu at the point where 
            // it is right clicked
            contextMenu.Placement = PlacementMode.RelativePoint;

            // Place the menu to the right of the click
            TextPointer position = rtb.Selection.End;

            if (position == null) return;

            // Create the menu
            Rect positionRect = position.GetCharacterRect(LogicalDirection.Forward);
            contextMenu.HorizontalOffset = positionRect.X;
            contextMenu.VerticalOffset = positionRect.Y;

            // Finally, mark the event as handled
            contextMenu.IsOpen = true;
            e.Handled = true;
        }

        void SaveRTBContent(Object sender, RoutedEventArgs args)
        {
            // Defines the range of text to save
            TextRange range = new TextRange(RichTB.Document.ContentStart, RichTB.Document.ContentEnd);

            // Create a stream to write to the file
            FileStream fStream = new FileStream(createdFile, FileMode.Create);

            // Save the content
            range.Save(fStream, DataFormats.XamlPackage);
            fStream.Close();

        }

        // Load text into RichTextBox
        void LoadRTBContent(Object sender, RoutedEventArgs args)
        {
            TextRange range;
            FileStream fStream;
            if (File.Exists(createdFile))
            {
                range = new TextRange(RichTB.Document.ContentStart, RichTB.Document.ContentEnd);
                fStream = new FileStream(createdFile, FileMode.OpenOrCreate);
                range.Load(fStream, DataFormats.XamlPackage);
                fStream.Close();
            }
        }
    }
}
