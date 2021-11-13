namespace P2_2_1204025
{
    public class ciri
    
    
    {
        private string Nama;
        private string Jenis;
        private string Warna;

    public ciri()
    {

    }
        
        public ciri(string nama, string jenis, string warna)
        {
            
            this.Jenis = jenis;
            this.Warna = warna;
            this.Nama =  nama;
        } 
            public string Namahewan
        {
            get
            {
                return Nama;    
            }
            set
            {
                Nama = value;
            }
        }

        public string Jeniss
        {
            get
            {
                return Jenis;    
            }
            set
            {
                Jenis = value;
            }
        }

        public string Warnaa
        {
            get
            {
                return Warna;    
            }
            set
            {
                Warna = value;
            }
        }
        
        public int umur;   

    }

        
    
}