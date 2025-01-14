using System.ComponentModel;
using System.Windows.Input;
using NoesisGUICSharp_Testing.Services;

namespace NoesisGUICSharp_Testing.ModelViews
{
    public class GamePlayModelView : IModelView
    {
        public ICommand ButtonBackCommand { get; }

        public GamePlayModelView()
        {
            ButtonBackCommand = new DelegateCommand(ExecuteButtonBackCommand);
        }

        protected void ExecuteButtonBackCommand(object args)
        {

        }
    }
}
