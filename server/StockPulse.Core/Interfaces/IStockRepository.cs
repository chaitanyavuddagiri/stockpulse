using StockPulse.Core.Models;

namespace StockPulse.Core.Interfaces;
public interface IStockRepository : IRepository<Stock>
{
    Task<Stock?> GetByTickerAsync(string ticker);
    Task<List<Stock>> GetByTickersAsync(List<string> tickers);
    Task<List<Stock>> SearchByNameOrTickerAsync(string searchTerm);
}