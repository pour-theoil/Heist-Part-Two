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
            if (AlarmScore > 0 || VaultScore > 0 || SecureityGaurdScore > 0)
            {
                return true;
            }
            
            else return false;
        }
    }
}