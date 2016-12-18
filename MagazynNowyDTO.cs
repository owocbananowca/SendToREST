namespace SendToREST.DTO
{
    public class MagazynNowyDTO : ObjectNewDTOs
    {
        public string nazwa { get; set; }
        public int? max_rozmiar { get; set; }
        public int? priorytet { get; set; }
        //public int lekarz { get; set; }
    }
}