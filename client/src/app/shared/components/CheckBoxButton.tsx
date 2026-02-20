import { Checkbox, FormControlLabel, FormGroup } from "@mui/material";
import { useEffect, useState } from "react";

type Props = {
    items: string[];
    checked : string[];
    onChange:(items : string[]) => void;
}

export default function CheckBoxButton({items, checked, onChange}: Props) {
    const [checkedItems, setCheckedItems] = useState(checked);

    useEffect(()=>{
        setCheckedItems(checked)
    },[checked])

    const handleToogle = (value: string) => {
        const updatedChecked = checkedItems?.includes(value)
        ? checkedItems.filter(item => item !== value)
        : [...checkedItems,value]

        setCheckedItems(updatedChecked);
        onChange(updatedChecked);
    }

  return (
    <FormGroup>
        {items.map((item)=>(
            <FormControlLabel 
                key={item} 
                control={<Checkbox 
                    checked={checkedItems.includes(item)}
                    color='secondary' 
                    onClick={()=>handleToogle(item)}
                    sx={{py:0.7,fontSize:40}}/>} 
                label={item} 
                />
        ))}
    </FormGroup>
  )
}