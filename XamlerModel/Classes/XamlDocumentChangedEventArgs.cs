using System;

namespace XamlerModel.Classes
{
    public class XamlDocumentChangedEventArgs : EventArgs
    {
        public XamlDocumentChangedEventArgs(XamlDocument document)
        {
            Document = document;
        }

        public virtual XamlDocument Document { get; }
    }
}
