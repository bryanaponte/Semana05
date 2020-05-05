using System;
using System.Windows.Input;

namespace Semana05.ViewModel
{
    public class RelayCommand<T> : ICommand
    {
        #region Fields

        readonly Action<T> _execute = null;
        readonly Predicate<T> _canExecute = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand{T}"/>
        /// </summary>
        /// <param name="execute">Delegate to execute when Execute is called on the command.</param>
        /// <remarks><seealso cref="CanExecute"/>will always return true</remarks>
        public RelayCommand(Action<T> execute)
            : this(execute, null)
        {

        }
        public RelayCommand(Action<T> execute, Predicate<T> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }
        #endregion

        #region ICommand Members

        ///<summary>
        /// Defines the method
        /// </summary>
        /// <param name="parameter">Data used by the command</param>
        /// <returns>
        /// true if this command can be executed; otherwise, false.
        /// </returns>

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute((T)parameter);
        }

        ///<summary>
        ///Ocurrs when changes ocurr
        ///</summary>

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }

        }
        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        #endregion




    }
}