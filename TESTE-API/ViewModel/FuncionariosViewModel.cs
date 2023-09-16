using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TESTE_API.ViewModel
{
    public class FuncionariosViewModel
    {
        public int IdFuncionario { get; set; }
        public int IdCargo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        [JsonConverter(typeof(DateOnlyConverter))]
        public DateOnly DataAdmissao { get; set; }
        public string Ctps { get; set; }
        public decimal SalarioBruto { get; set; }

        [JsonConverter(typeof(DateOnlyConverter))]
        public DateOnly DataNascimento { get; set; }
        public string Banco { get; set; }
        public string Conta { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public string NomeSocial { get; set; }
        public string Genero { get; set; } 
        public string Endereco { get; set; }
    }

    public class DateOnlyConverter : JsonConverter<DateOnly>
    {
        public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var dateObject = JsonSerializer.Deserialize<DateObject>(ref reader, options);
            return new DateOnly(dateObject.year, dateObject.month, dateObject.day);
        }

        public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
        {
            var dateObject = new DateObject
            {
                year = value.Year,
                month = value.Month,
                day = value.Day
            };
            JsonSerializer.Serialize(writer, dateObject, options);
        }

        private class DateObject
        {
            public int year { get; set; }
            public int month { get; set; }
            public int day { get; set; }
        }
    }
}
