using System.Linq;

namespace DevIO.Business.Models.Validations.Documentos
{
    public class CpfValidacao
    {
        public const int TamanhoCpf = 11;

        public static bool Validar(string cpf)
        {
            var cpfNumeros = Utils.ApenasNumeros(cpf);

            if (!TamanhoValido(cpfNumeros)) return false;
            return !TemDigitosRepetidos(cpfNumeros) && TemDigitosValidos(cpfNumeros);
        }

        private static bool TamanhoValido(string valor)
        {
            return valor.Length == TamanhoCpf;
        }

        private static bool TemDigitosRepetidos(string valor)
        {
            string[] invalidNumbers =
            {
                "00000000000",
                "11111111111",
                "22222222222",
                "33333333333",
                "44444444444",
                "55555555555",
                "66666666666",
                "77777777777",
                "88888888888",
                "99999999999"
            };
            return invalidNumbers.Contains(valor);
        }

        private static bool TemDigitosValidos(string valor)
        {
            var number = valor.Substring(startIndex: 0, length: TamanhoCpf - 2);
            var digitoVerificador = new DigitoVerificador(number)
                .ComMultiplicadoresAte(primeiroMultiplicador: 2, ultimoMultiplicador: 11)
                .Substituindo(substituto: "0", paramsdigitos: 10, 11);
            var firstDigit = digitoVerificador.CalculaDigito();
            digitoVerificador.AddDigito(firstDigit);
            var secondDigit = digitoVerificador.CalculaDigito();

            return string.Concat(firstDigit, secondDigit) == valor.Substring(startIndex: TamanhoCpf - 2, length: 2);
        }      

    }

    public class CnpjValidacao
    {
        public const int TamanhoCnpj = 14;

        public static bool Validar(string cnpj)
        {
            var cnpjNumeros = Utils.ApenasNumeros(cnpj);

            if (!TamanhoValido(cnpjNumeros)) return false;
            return !TemDigitosRepetidos(cnpjNumeros) && TemDigitosValidos(cnpjNumeros);
        }

        private static bool TamanhoValido(string valor)
        {
            return valor.Length == TamanhoCnpj;
        }

        private static bool TemDigitosRepetidos(string valor)
        {
            string[] invalidNumbers =
            {
                "00000000000000",
                "11111111111111",
                "22222222222222",
                "33333333333333",
                "44444444444444",
                "55555555555555",
                "66666666666666",
                "77777777777777",
                "88888888888888",
                "99999999999999"
            };
            return invalidNumbers.Contains(valor);
        }

        private static bool TemDigitosValidos(string valor)
        {
            var number = valor.Substring(startIndex: 0, length: TamanhoCnpj - 2);
            var digitoVerificador = new DigitoVerificador(number)
                .ComMultiplicadoresAte(primeiroMultiplicador: 2, ultimoMultiplicador: 14)
                .Substituindo(substituto: "0", paramsdigitos: 13, 14);
            var firstDigit = digitoVerificador.CalculaDigito();
            digitoVerificador.AddDigito(firstDigit);
            var secondDigit = digitoVerificador.CalculaDigito();

            return string.Concat(firstDigit, secondDigit) == valor.Substring(startIndex: TamanhoCnpj - 2, length: 2);
        }
    }
}
