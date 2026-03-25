using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.Sales.Editors;
using static StdPlatBS100.StdBSTipos;

namespace ADSucoremaExtensibilidade
{
    public class PriClass1 : EditorVendas
    {
        public override void AntesDeImprimir(ref bool Cancel, ExtensibilityEventArgs e)
        {
            if (this.DocumentoVenda.Tipodoc == "ORC")
            {
                

                Cancel = true;
            }
        }
    }
}