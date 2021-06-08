namespace heistpart2
{
    public class Bank
    {
        public int CashOnHand {get; set; }
        public int AlarmScore {get; set; }
        public int VaultScore {get; set; }
        public int SecureityGaurdScore {get; set; }
        public bool IsSecure()
        {
            if(CashOnHand > 0)
            {
                return true;
            }
            else if ( AlarmScore > 0)
            {
                return true;
            }
            else if ( VaultScore > 0)
            {
                return true;
            }
            else if ( SecureityGaurdScore > 0)
            {
                return true;
            }
            else return false;
        }
    }
}