namespace AcessModifiers.Structures
{
    public struct PublicStructure
    {
        // In structures, we can only define: private, internal, and public fields.
        // Structures do not support class or struct inheritance
        #region Fields members
        private string _privateField;
        internal string InternalField;
        public string PublicField;

        // Trying to create internal struct here inside the public struct
        private InternalStructure InternalStruct;

        #endregion

        #region Methods
        internal void StructMethod()
        {
            // Trying to access InternalStruct fields - only internal & public members are accessable only.
            InternalStruct.PublicField = string.Empty;
            InternalStruct.InternalField = string.Empty;
        }
        #endregion
    }
}