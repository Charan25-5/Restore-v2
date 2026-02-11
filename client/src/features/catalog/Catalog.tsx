import { useEffect, useState } from 'react';
import type { Product } from '../../app/models/product';
import ProductList from './ProductList';



export default function Catalog() {

  const[products,setProducts] = useState<Product[]>([]);

  useEffect(()=>{
    fetch('https://localhost:7280/api/products')
    .then(response => response.json())
    .then(data => setProducts(data));
  },[])  //wepage reload   
    

  return (
    <>
      <ProductList products={products}/>
    </>
  )
}
