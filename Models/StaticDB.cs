namespace s17_l1.Models
{
    public static class StaticDb
    {
        private static int _maxId = 4;
        private static List<Employees> _employees = [
            new Employees(){Id= 1, Nome = "Fabrizio", Cognome = "De Andrè", Indirizzo = "Via del Campo", Coniugato = true, NumeroFigli = 2, Mansione = "Cantautore" },
            new Employees(){Id= 2, Nome = "Maurizo", Cognome = "Costanzo", Indirizzo = "Via BBonii", Coniugato = true, NumeroFigli = 3, Mansione = "Showman" },
            new Employees(){Id= 3, Nome = "Charles", Cognome = "Manson", Indirizzo = "Via Polanski", Coniugato = false, NumeroFigli = 0, Mansione = "Musicista" },
            new Employees(){Id= 4, Nome = "Osvaldo", Cognome = "Paniccia", Indirizzo = "Via Sattooh", Coniugato = false, NumeroFigli = 0, Mansione = "Artista" }      
        ];

        public static List<Employees> GetAll()
        {
            return _employees;
        }

        public static Employees? GetById(int? id)
        {
            if (id is null) return null;
            for(int i = 0; i < _employees.Count; i++)
            {
                Employees employees = _employees[i];
                if (employees.Id == id)
                {
                    return employees;
                }
            }

            return null ;
        }
        public static Employees Add(string nome, string cognome, string indirizzo, bool coniugato, int numeroFigli, string mansione)
        {
            _maxId++;

            var employees = new Employees(){ Id = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, Coniugato = coniugato, NumeroFigli =numeroFigli, Mansione = mansione };
            _employees.Add(employees);
            return employees;
        }



        private static List<Payment> _payment = [
            new Payment(){Id= 1, PeriodoPagamento = new DateOnly (2024, 02, 24), Totale = 1500 , StipendioAcconto = true},
            new Payment(){Id= 2, PeriodoPagamento = new DateOnly (2024, 02, 25), Totale = 1600 , StipendioAcconto = true},
            new Payment(){Id= 3, PeriodoPagamento = new DateOnly (2024, 02, 23), Totale = 1700 , StipendioAcconto = true},
            new Payment(){Id= 4, PeriodoPagamento = new DateOnly (2024, 02, 22), Totale = 1550 , StipendioAcconto = true}
        ];

        public static List<Payment>GetAllPayment()
        {
            return _payment;
        }

        public static Payment Add( DateOnly periodoPagamento, decimal totale, bool stipendioAcconto)
        {
            _maxId++;

            var payment = new Payment(){Id = _maxId, PeriodoPagamento = periodoPagamento, Totale = totale, StipendioAcconto = stipendioAcconto};
            _payment.Add(payment);
            return payment;
        }

    }
}