namespace AcessModifiers.Classes
{
    public class PublicClass
    {
        #region member fields
        private string _privateField;
        internal string internalField;
        public string publicField;

        protected string ProtectedField;
        protected internal string ProtectedInternalField;
        private protected string PrivateProtectedField;

        // Define a new member using InternalClass class
        private InternalClass InternalClassField;

        #endregion

        #region Methods
        public void Method()
        {
            InternalClassField.publicField = string.Empty;
            InternalClassField.internalField = string.Empty;
            InternalClassField.ProtectedInternalField = string.Empty;
            InternalClassField.ProtectedInternalField = string.Empty;

        }
        #endregion
    }
}