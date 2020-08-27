using DevBoost.DependecyInjection.Interfaces;
using System.Text.Json.Serialization;


namespace DevBoost.DependecyInjection.Models.DI_GetterSetter
{
    public class Esportista_GS
    {

        private IAtividades _atividades;

        [JsonIgnore] //Faz com que essa propriedade não seja serializada no JSON
        public IAtividades Atividades
        {
            get { return _atividades; }
            set { _atividades = value; }
        }        

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Pais { get; set; }        
        public string Atividade
        {
            get { return _atividades.GetNome(); }            
        }
    }
}
