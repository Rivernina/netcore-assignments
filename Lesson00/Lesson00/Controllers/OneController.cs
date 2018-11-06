using Lesson00.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson00.Controllers
{
    class OneController
    {
        public SingleModel singleModel;
        public void Form()
        {
            singleModel = Views.One.Form.EnterChar();
        }
        public void Index()
        {
            Views.One.Index.Result(singleModel);
        }


    }
}
