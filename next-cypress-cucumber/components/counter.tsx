import React from "react";

type Props = {
  initialCount: number;
}

const Counter = ({ initialCount }: Props) => {
  const [count, setCount] = React.useState(initialCount);
  return (
    <div>
      <h1>Counter</h1>
      <h3>{count}</h3>
      <button onClick={() => setCount(count + 1)}>Add</button>
      <button onClick={() => setCount(count - 1)}>Subtract</button>
    </div>
  );
};

export default Counter;
