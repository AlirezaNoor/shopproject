namespace OperationResult
{
    public class OperationResults
    {
        public  string  massege   { get; set; }
        public  bool  IsSeccuse { get; set; }

        public OperationResults()
        {
            IsSeccuse = false;
        }

        public OperationResults secsseced(string Massege = "عملیات با موفقیت انجام شد")
        {
            IsSeccuse = true;
            massege = Massege;
            return this;
        }
        public OperationResults isfailed(string Massege = "عملیات با موفقیت انجام نشد")
        {
            IsSeccuse = false;
            massege = Massege;
            return this;
        }
    }
    
}
