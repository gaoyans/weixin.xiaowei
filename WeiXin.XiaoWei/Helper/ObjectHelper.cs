�}a�  �  �|�8I�L�LQ
���;���)h�,�^ܣS����#�����^�94�Gi�����l��Ը�F�Z���[�v�g� �������ݳ�"|?c#=�:�H$�Q�ea��(�����p����a��	�'�A �+iJH��w��8��L�e�>���&�$`�6G��&�{+������,�g�K��r/`����xτ`s����	iKV�,��P/���|��/*��n�D����v;ޮ�Y�?���C��X���%u 2�zvwV�<�q	\V��a���%�$%**�8����;�|<�������<�����cv�F��d*Bq���x��]`t9�,5,����v��hV�y�Z0������t6������� A���ׄ��P�Oc�M:�F��Duz�9o꾙����(��I�c��g�`O��g�e��Q1�-��J���*Ӹ7���a���J.��/��T��,Ч�����v�@��P���~u�ɸ)��   public static F DeepCopy<T, F>(T original)
        {
            var json = SerializeHelper.JsonSerialize<T>(original);
            var result = SerializeHelper.JsonDeserialize<F>(json);
            return result;
        }

        public static void DeepCopy<T, F>(T original, F desination)
        {
            desination = DeepCopy<T, F>(original);
        }

    }
}