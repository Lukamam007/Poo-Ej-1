namespace Jugadores{

    public interface Ijugador{

      public int tiempo{get;set;}
      public bool Cansado();
      public void Correr (int minutos);
      public void Descansar (int minutos);
      
