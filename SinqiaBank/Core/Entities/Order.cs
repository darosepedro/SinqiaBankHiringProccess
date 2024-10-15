namespace SinqiaBankHiringProccess.Core.Entities
{
    public class Order
    {
        public Guid Id { get; private set; } = Guid.NewGuid(); // Identificador único
        public string CustomerName { get; private set; }        // Nome do cliente
        public string ProductName { get; private set; }         // Nome do produto
        public DateTime OrderDate { get; private set; }         // Data do pedido
        public string Status { get; private set; }              // Status do pedido

        // Construtor para inicialização
        public Order(string customerName, string productName)
        {
            if (string.IsNullOrEmpty(customerName))
                throw new ArgumentException("O nome do cliente não pode ser vazio.");

            if (string.IsNullOrEmpty(productName))
                throw new ArgumentException("O nome do produto não pode ser vazio.");

            CustomerName = customerName;
            ProductName = productName;
            OrderDate = DateTime.Now;
            Status = "Novo";
        }

        // Método para atualizar o status do pedido
        public void UpdateStatus(string newStatus)
        {
            if (string.IsNullOrEmpty(newStatus))
                throw new ArgumentException("O status não pode ser vazio.");

            Status = newStatus;
        }

        public override string ToString()
        {
            return $"Pedido: {Id}\nCliente: {CustomerName}\nProduto: {ProductName}\nData: {OrderDate}\nStatus: {Status}";
        }
    }

}
