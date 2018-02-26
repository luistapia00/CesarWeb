namespace CesarWeb.Services
{

    public class SeguridadService : ISeguridadService<int>
    {
        static string ABECEDARIO = ("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
        static string abecedario = ("abcdefghijklmnñopqrstuvwxyz");

        ///  Aquí deben hacer todo el código necesario para Desencriptar el mensaje
        public string DesEncriptar(string Mensaje, int clave)
        {
            int i = 0;
            int j = 0;
            string equitativo = Mensaje;
            for(i=0;i<Mensaje.Length;i++){
                for(j=0;j<=54;j++){
                    if(Mensaje[i]==ABECEDARIO[j]){
                        equitativo=equitativo.Replace(equitativo[i],ABECEDARIO[j-clave]);
}
                    if(Mensaje[i]==abecedario[j]){
                        equitativo=equitativo.Replace(equitativo[i],abecedario[j-clave]);
}
}
}
            Mensaje = equitativo;
            return Mensaje;
        }

        
        
        ///  Aquí deben hacer todo el código necesario para Encriptar el mensaje
        public string Encriptar(string Mensaje, int clave)
        {
            int a = 0;
            int b = 0;
            string diferenciar = Mensaje;
            for (a=0;a<Mensaje.Length;a++){
                for (b=0;b<=54;b++){
                    if (Mensaje[a]==ABECEDARIO[b]){
                        diferenciar=diferenciar.Replace(diferenciar[a],ABECEDARIO[b+clave]);
}
                    if (Mensaje[a]==abecedario[b]){
                        diferenciar=diferenciar.Replace(diferenciar[a],abecedario[b+clave]);
}
}
}
            Mensaje = diferenciar;
            return Mensaje;
        }
    }


}