namespace PrimeNumberFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up the form controls
            button.Text = "Generate Prime";
            listView.View = View.Details;
            listView.Columns.Add("Prime Numbers", 150);
        }

        private async void button_Click(object sender, EventArgs e)
        {
            // Generate a list of integers from 1 to 1000
            List<int> numbers = GenerateIntegers(1, 1000).ToList();

            // Get prime numbers using different methods
            IEnumerable<int> primes = await Task.Run(() => GetPrimes(numbers));

            // Process and display the prime numbers in a background task
            await ProcessPrimesAsync(primes);
        }

        private IEnumerable<int> GenerateIntegers(int start, int count)
        {
            for (int i = start; i < start + count; i++)
            {
                yield return i;
            }
        }

        private IEnumerable<int> GetPrimes(IEnumerable<int> numbers)
        {
            return numbers.Where(IsPrime);
        }

        private bool IsPrime(int number)
        {
            // Check if the number is less than or equal to 1
            if (number <= 1)
                return false;

            // Check for divisibility by numbers from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                // If the number is divisible by any other number, it's not prime
                if (number % i == 0)
                    return false;
            }

            // If no divisors were found, the number is prime
            return true;
        }

        // second IsPrime. This one is not used. It is just second altenative method.
        private bool IsPrime2(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int i = 5;
            int w = 2;

            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;

                i += w;
                w = 6 - w;
            }

            return true;
        }

        private async Task ProcessPrimesAsync(IEnumerable<int> primes)
        {
            await Task.Run(() =>
            {
                foreach (var prime in primes)
                {
                    // Add prime numbers directly to the ListView
                    Invoke(new Action(() =>
                    {
                        listView.Items.Add($"{prime} is a prime number\r\n");
                    }));
                }
            });
        }
    }
}