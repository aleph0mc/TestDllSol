using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DllTest
{


    [ComVisible(true)]
    [Guid("1B415838-2C45-4DA0-9ACA-B5D4DF84340D")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface ITestDll
    {
        int Add2Numbers(int A, int B);
    }


    [ComVisible(true)]
    [ComDefaultInterface(typeof(ITestDll))]
    [ClassInterface(ClassInterfaceType.None)]
    public class TestDll : ITestDll
    {
        public int Add2Numbers(int A, int B)
        {
            return A + B;
        }
    }
}
