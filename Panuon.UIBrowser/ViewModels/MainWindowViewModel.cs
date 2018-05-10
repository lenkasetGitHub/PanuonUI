﻿using Caliburn.Micro;
using Panuon.UIBrowser.ViewModels.Partial;
using System.ComponentModel.Composition;

namespace Panuon.UIBrowser.ViewModels
{
    [Export(typeof(IShell))]

    public class MainWindowViewModel : Conductor<IShell>.Collection.OneActive, IShell
    {
        public MainWindowViewModel()
        {
            ActivateItem(new IntroductionViewModel());
        }

       public void ChangeSelect(int select)
        {
            switch (select)
            {
                case 0:
                    ActivateItem(new IntroductionViewModel());
                    return;
                case 1:
                    ActivateItem(new WindowsViewModel());
                    return;
                case 2:
                    ActivateItem(new ButtonsViewModel());
                    return;
                case 3:
                    ActivateItem(new TextBoxsViewModel());
                    return;
                case 4:
                    ActivateItem(new CheckBoxsViewModel());
                    return;
                case 5:
                    ActivateItem(new RadioButtonsViewModel());
                    return;

            }
        }

    }
}
