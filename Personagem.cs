namespace Aula_3
{
    public class Personagem
    {
            public string name;
            public int age;
            public string armadura;


            public float Atacar(float forca , float potencia)
            {
                return forca * potencia;
            }

            public string Defender()
            {
                return "O personagem atacou com um pode com mais de";
            }



    }
}