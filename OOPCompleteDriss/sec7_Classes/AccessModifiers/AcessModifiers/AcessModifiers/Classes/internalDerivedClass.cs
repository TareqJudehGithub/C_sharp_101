namespace AcessModifiers.Classes
{
    internal class InternalDerivedClass : InternalClass
    {
        public void MyMethod()
        {
            // Accessing members from InternalClass
            internalField = string.Empty;
            publicField = string.Empty;
            ProtectedField = string.Empty;
            ProtectedInternalField = string.Empty;
            PrivateProtectedField = string.Empty;
        }
    }
}