using Avalonia.Controls;
using Avalonia.VisualTree;

namespace TestCalcTraining
{
    public class UnitTest
    {
        [Fact]
        public async void FromButtonToTextBlockTest()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var TextBlock = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(c => c.Name == "textInput");

            button.Command.Execute(button.CommandParameter);

            await Task.Delay(50);
            var textBlockContent = TextBlock.Text;

            Assert.True(textBlockContent.Equals("I"));
        }

        [Fact]
        public async void ClearTest()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);
            
            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var ButtonClear = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "ButtonClear");
            var TextBlock = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(c => c.Name == "textInput");
            

            button.Command.Execute(button.CommandParameter);
            ButtonClear.Command.Execute(button.CommandParameter);


            var TextBlockContent = TextBlock.Text;
            await Task.Delay(100);

            

            Assert.True(TextBlockContent.Equals(""));
        }
    }
}