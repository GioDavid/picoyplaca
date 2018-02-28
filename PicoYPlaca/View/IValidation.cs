using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PicoYPlaca.Model;

namespace PicoYPlaca.View
{
    public interface IValidation
    {
        Date date { get; set; }
        Vehicle vehicle { get; set; }
        Time time { get; set; }
        Boolean isValid { get; set; }
        String error { get; set; }
    }
}
