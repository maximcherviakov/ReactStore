import {
  FormControl,
  RadioGroup,
  FormControlLabel,
  Radio,
} from "@mui/material";

interface Props {
  options: any[];
  onChange: (Event: any) => void;
  selectedValue: string;
}

export default function RadioButtonGroup({
  options,
  onChange,
  selectedValue,
}: Props) {
  return (
    <FormControl component="fieldset">
      <RadioGroup onChange={onChange} value={selectedValue}>
        {options.map(({ value, label }) => (
          <FormControlLabel
            control={<Radio />}
            value={value}
            label={label}
            key={value}
          />
        ))}
      </RadioGroup>
    </FormControl>
  );
}
