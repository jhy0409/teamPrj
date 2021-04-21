namespace teamProject.model
{
    class DrugOrder
    {
        public Drug drug { get; set; }
        public Entp entp { get; set; }
        public int count { get; set; }

        public DrugOrder(Drug drug, Entp entp, int count)
        {
            this.drug = drug;
            this.entp = entp;
            this.count = count;
        }

        public int Count { get => count; set => count = value; }
        internal Drug Drug { get => drug; set => drug = value; }
        internal Entp Entp { get => entp; set => entp = value; }
    }
}
