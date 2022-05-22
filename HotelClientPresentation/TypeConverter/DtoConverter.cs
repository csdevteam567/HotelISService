using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace HotelClientPresentation
{
    public class DtoConverver<TypeIn, TypeOut> where TypeOut : new()
    { 
        public TypeOut ConvertType(TypeIn data)
        {
            PropertyDescriptorCollection propertiesIn =
                TypeDescriptor.GetProperties(typeof(TypeIn));

            TypeOut result = new TypeOut();
            PropertyDescriptorCollection propertiesOut =
                TypeDescriptor.GetProperties(typeof(TypeOut));

            foreach(PropertyDescriptor propIn in propertiesIn )
            {
                foreach (PropertyDescriptor propOut in propertiesOut)
                {
                    if (propIn.Name == propOut.Name)
                    {
                        propOut.SetValue(result, propIn.GetValue(data));
                    }
                }
            }
        return result;
        }
    }
}
