namespace Inheritance
{
    internal class Radio : ElectronicDevice
    {
        // Constructor

        // Passing Radio parameters to the base class ElectronicDevice constructor
        public Radio(bool isOn, string brand) : base(isOn: isOn, brand: brand)
        {
        }

        // Methods
        //public void SwitchOn()
        //{
        //    /* This method switches on the radio */
        //    IsOn = true;
        //}
        //public void SwitchOff()
        //{
        //    /* This method switches on the radio */
        //    IsOn = false;
        //}

        public void ListenToRadio()
        {
            if (IsOn) Console.WriteLine("Listening to the radio!");
            else Console.WriteLine("Radio is switched off, switch it on if you want to listen.");
        }
    }
}
