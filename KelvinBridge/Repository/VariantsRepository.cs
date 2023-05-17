using KelvinBridge.Models;

namespace KelvinBridge.Repository
{
    public class VariantsRepository : IRepository<BridgeModel>
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BridgeModel> GetAll()
        {
            return new List<BridgeModel>
            {
                new() { VariantName = "Вариант 1", Ra = 1.2, Rm = 2.5, Rn = 3.8, RM = 4.1, RN = 5.3 },
                new() { VariantName = "Вариант 2", Ra = 2.3, Rm = 3.6, Rn = 4.9, RM = 5.2, RN = 6.4 },
                new() { VariantName = "Вариант 3", Ra = 3.4, Rm = 4.7, Rn = 6.0, RM = 6.3, RN = 7.5 },
                new() { VariantName = "Вариант 4", Ra = 4.5, Rm = 5.8, Rn = 7.1, RM = 7.4, RN = 8.6 },
                new() { VariantName = "Вариант 5", Ra = 5.6, Rm = 6.9, Rn = 8.2, RM = 8.5, RN = 9.7 },
                new() { VariantName = "Вариант 6", Ra = 6.7, Rm = 7.3, Rn = 8.9, RM = 9.2, RN = 10.5 },
                new() { VariantName = "Вариант 7", Ra = 7.8, Rm = 8.4, Rn = 9.9, RM = 10.2, RN = 11.5 },
                new() { VariantName = "Вариант 8", Ra = 8.9, Rm = 9.5, Rn = 10.9, RM = 11.2, RN = 12.5 },
                new() { VariantName = "Вариант 9", Ra = 9.0, Rm = 9.6, Rn = 11.0, RM = 11.3, RN = 12.6 },
                new() { VariantName = "Вариант 10", Ra = 9.1, Rm = 9.7, Rn = 11.1, RM = 11.4, RN = 12.7 },
                new() { VariantName = "Вариант 11", Ra = 9.2, Rm = 9.8, Rn = 11.2, RM = 11.5, RN = 12.8 },
                new() { VariantName = "Вариант 12", Ra = 9.3, Rm = 9.9, Rn = 11.3, RM = 11.6, RN = 12.9 },
                new() { VariantName = "Вариант 13", Ra = 9.4, Rm = 10.0, Rn = 11.4, RM = 11.7, RN = 13.0 },
                new() { VariantName = "Вариант 14", Ra = 9.5, Rm = 10.1, Rn = 11.5, RM = 11.8, RN = 13.1 },
                new() { VariantName = "Вариант 15", Ra = 9.6, Rm = 10.2, Rn = 11.6, RM = 11.9, RN = 13.2 },
                new() { VariantName = "Вариант 16", Ra = 9.7, Rm = 10.3, Rn = 11.7, RM = 12.0, RN = 13.3 },
                new() { VariantName = "Вариант 17", Ra = 9.8, Rm = 10.4, Rn = 11.8, RM = 12.1, RN = 13.4 },
                new() { VariantName = "Вариант 18", Ra = 9.9, Rm = 10.5, Rn = 11.9, RM = 12.2, RN = 3.5 }
            };
        }

        public BridgeModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(BridgeModel item)
        {
            throw new NotImplementedException();
        }

        public void Update(BridgeModel item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
