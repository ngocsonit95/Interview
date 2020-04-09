using System;

namespace Testing.Interface
{
    //Khi một class thi hành một Interface, bạn phải thực hiện hoặc khai báo lại toàn bộ các phương thức có trong Interface đó.
    public class IDispose : IDisposable
    {
        // Flag: Has Dispose already been called?
        bool disposed = false;
        private System.ComponentModel.IContainer components = null;
        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing && components != null)
            {
                components.Dispose();
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }
    }
}