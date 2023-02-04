using CoreSM.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreSM.Models
{
    public class DropdownHelper
    {
        //SalesDbContext db = null;
        int selectedValue = 0;
        int compID = 1022;
        private readonly IUnitOfWork _unitOfWork;
        public DropdownHelper(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
             

        public IEnumerable<SelectListItem> GetWholeSale()
        {
            List<COA_M> data = new List<COA_M>();
            data.Add(new COA_M { CAC_Code = 1, CATitle = "Retail Price" });
            data.Add(new COA_M { CAC_Code = 2, CATitle = "WholeSale Price" });

            var datas =
               data.Select(s => new SelectListItem()
               {
                   Text = s.CATitle,
                   Value = s.CAC_Code.ToString(),
               }).ToList();
            datas.Insert(0, new SelectListItem() { Text = "Select", Selected = true, Value = "0" });

            return new SelectList(datas, "Value", "Text", selectedValue);
        }     
    }
}