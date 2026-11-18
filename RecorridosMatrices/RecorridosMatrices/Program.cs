using static System.Console;



//MATRIZ
int[,] original = new int[5,5]; //La matriz debe ser 5x5

InicializarTabla(original); //Ponemos valores a la tabla
WriteLine("Recorrido normal");
RecorrerPorFilas(original); //Recorrido normal
WriteLine("Recorrido normal inverso");
RecorrerPorFilasDesc(original); //Recorrido normal inverso
WriteLine("Recorrido por columnas");
RecorrerPorColumnas(original); //Recorrido por columnas
WriteLine("Recorrido por columnas inverso");
RecorrerPorColumnasDesc(original); //Recorrido por columnas inverso
WriteLine("Recorrer por filas pero de derecha a izquierda");
RecorrerPorFilasAlRevés(original); //Recorrer por filas pero de derecha a izquierda
WriteLine("Recorrer por filas de derecha a izquierda descendente");
RecorrerPorFilasAlRevésDesc(original); //Recorrer por filas de derecha a izquierda descendente
//Y los otros dos de columnas --> muy easy

WriteLine("Recorrer diagonal");
RecorrerDiagonal(original); //Recorrer diagonal (valores[i,i])
WriteLine("Recorrer diagonal de abajo hacia arriba");
RecorrerDiagonalAscendente(original); //Recorrer diagonal de abajo hacia arriba
WriteLine("Recorrer la diagonal al revés");
RecorrerDiagonalInversa(original); //Recorrer la diagonal al revés
WriteLine("Recorrer diagonal de abajo hacia arriba al revés");
RecorrerDiagonalInversaAscendente(original); //Recorrer diagonal de abajo hacia arriba al revés



return;

void InicializarTabla(int[,] valores)
{
    for (int i = 0; i < valores.GetLength(0); i++)
    {
        for (int j = 0; j < valores.GetLength(1); j++)
        {
            valores[i, j] = j * i;
        }
    }
}

void RecorrerPorFilas(int[,] valores)
{
    for (int i = 0; i < valores.GetLength(0); i++)
    {
        for (int j = 0; j < valores.GetLength(1); j++)
        {
            Write($"[{valores[i,j],2}]");
        }

        WriteLine();

    }
}

void RecorrerPorFilasDesc(int[,] valores)
{
    for (int i = valores.GetLength(0)-1; i >= 0; i--)
    {
        for (int j = 0; j < valores.GetLength(1); j++)
        {
            Write($"[{valores[i,j],2}]");
        }

        WriteLine();
        
    }
}


void RecorrerPorColumnas(int[,] valores)
{
    for (int i = 0; i < valores.GetLength(0); i++)
    {
        for (int j = 0; j < valores.GetLength(1); j++)
        {
            Write($"[{valores[j,i], 2}]");
        }
        WriteLine();
    }
}

void RecorrerPorColumnasDesc(int[,] valores)
{
    for (int i = valores.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = 0; j < valores.GetLength(1); j++)
        {
            Write($"[{valores[j,i], 2}]");
        }
        WriteLine();
    }
}


void RecorrerPorFilasAlRevés(int [,] valores)
{
    for (int i = 0; i < valores.GetLength(1); i++)
    {
        for (int j = valores.GetLength(1) - 1; j >= 0; j--)
        {
            Write($"[{valores[i,j], 2}]");
        }
        WriteLine();
    }
}

void RecorrerPorFilasAlRevésDesc(int[,] valores)
{
    for (int i = valores.GetLength(1) -1; i >= 0; i--)
    {
        for (int j = valores.GetLength(1) - 1; j >= 0; j--)
        {
            Write($"[{valores[i,j], 2}]");
        }
        WriteLine();
    }
}

//================================DIAGONALES====================

void RecorrerDiagonal(int[,] valores)
{
    for (int i = 0; i < valores.GetLength(0); i++)
    {
        Write($"[{valores[i,i], 2}]"); 
    }
}

void RecorrerDiagonalAscendente(int[,] valores)
{
    for (int i = valores.GetLength(0)-1; i >= 0; i--)
    {
        Write($"[{valores[i,i], 2}]"); 
    }
}

void RecorrerDiagonalInversa(int[,] valores)
{
    int j = valores.GetLength(1) -1;
    for (int i = 0; i < valores.GetLength(0); i++)
    {
        Write($"[{valores[i,j], 2}]");
        j--;
    }
}

void RecorrerDiagonalInversaAscendente(int[,] valores)
{
    int j = valores.GetLength(0) -1;
    for (int i = valores.GetLength(0) -1; i >= 0; i--)
    {
        Write($"[{valores[i,j], 2}]");
        j--;
    }
}