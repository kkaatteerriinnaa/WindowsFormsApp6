using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public class SafePresenter
    {
        private readonly ISafeView _view;
        private readonly SafeModel _model;

        public SafePresenter(ISafeView view, SafeModel model)
        {
            _view = view;
            _model = model;

            _view.CodeSubmitted += OnCodeSubmitted;
        }

        private void OnCodeSubmitted(object sender, EventArgs e)
        {
            _model.Code = _view.Code;

            if (_model.Code == "1234")
            {
                MessageBox.Show("Сейф открыт!");
            }
            else
            {
                MessageBox.Show("Неверный код!");
            }
        }
    }
}
