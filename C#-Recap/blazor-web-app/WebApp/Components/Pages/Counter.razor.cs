namespace WebApp.Components.Pages
{
    public partial class Counter
    {   
        private int count = 0;



        public int Countercount => count;


 
        private void IncrementCount()

        {

            if (count < 9)
            {
                count++;
            }

        }

        private void DecrementCount()
        {

            if (count > -9)
            {

                count--;

            }

        }
    }
}