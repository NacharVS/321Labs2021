namespace Bank
{
    public struct PersonalData
    {
        //добавить свойства
        public string _FIO;
        public string _addres;

        public string FIO { get => _FIO; set => _FIO = value; }
        public string Addres { get => _addres; set => _addres = value; }

        public PersonalData(string FIO, string addres)
        {
            _FIO = FIO;
            _addres = addres;
        }
    }
}
