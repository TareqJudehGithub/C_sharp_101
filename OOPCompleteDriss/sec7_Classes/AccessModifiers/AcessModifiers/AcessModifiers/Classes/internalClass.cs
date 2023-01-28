namespace AcessModifiers.Classes
{
    internal class InternalClass
    {
        private string _privateField; 
        internal string internalField;
        public string publicField;

        protected string ProtectedField;
        protected internal string ProtectedInternalField;
        private protected string PrivateProtectedField;
    }
}
