namespace Inheritance
{
    internal class TV : ElectronicDevice
    {

        // Constructor
        public TV(bool isOn, string brand) : base(isOn: isOn, brand: brand)
        {
        }

        // Methods
        //public void SwitchOn()
        //{
        //    /* This method switches on the TV */
        //    IsOn = true;
        //}
        //public void SwitchOff()
        //{
        //    /* This method switches on the TV */
        //    IsOn = false;
        //}

        public void WatchTV()
        {
            if (IsOn) Console.WriteLine("Watching the TV!");
            else Console.WriteLine("TV is switched off, switch it on if you want to watch.");
        }
    }
}
