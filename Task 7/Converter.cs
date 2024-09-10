namespace Task_7
{
    internal class Converter
    {
        private double _usd, _eur, _uan;
        public Converter(double usd, double eur, double uan)
        {
            _usd = usd;
            _eur = eur;
            _uan = uan;
        }

        public double FromUSD(double usd)
        {
            return usd * _usd;
        }

        public double FromEUR(double eur)
        {
            return eur * _eur;
        }

        public double ToUSD(double uan)
        {
            return uan / _usd;
        }

        public double ToEUR(double uan)
        {
            return uan / _eur;
        }
    }
}
