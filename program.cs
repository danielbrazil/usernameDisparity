        static int[] usernameDisparity(string[] inputs)
        {
            int iLength;
            int iLengthSuffix;
            int iSum = 0;
            int iCount = 0;
            int[] result = new int[] { inputs.Length };

            string suffix = string.Empty;
            
            foreach (string palavra in inputs)  // aqui pego as palaras
            {
                iLength = palavra.Length;
                suffix = palavra;

                for (int i = 0; i < iLength; i++)
                {
                    iLengthSuffix = suffix.Length;
                    for (int j = iLengthSuffix; j > 0; j--)
                    {
                        if (palavra.StartsWith(suffix.Substring(0, j)))
                        {
                            iSum += j;
                            break;
                        }
                    }


                    suffix = suffix.Substring(1, suffix.Length - 1);
                }
                result[iCount] = iSum;

                iCount += 1;
            }
            return result;
        }
