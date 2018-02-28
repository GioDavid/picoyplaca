using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicoYPlaca.View;
using PicoYPlaca.Model;

namespace PicoYPlaca.Presenter
{
    class ValidationPresenter
    {
        #region Properties
        IValidation validationView;
        Validation validation;
        #endregion

        //Constructor for the presenter 
        public ValidationPresenter(IValidation view, Date date, Vehicle vehicle, Time time)
        {
            validationView = view;
            validation = new Validation(date, vehicle, time);
        }

        #region Functions

        public void canBeOnRoad()
        {
            validation.canBeOnRoad();
            validationView.isValid = validation.isValid;
            validationView.error = validation.error;
        }

        #endregion
    }
}
