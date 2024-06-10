import { useState, useId } from 'react'
import './App.css'

function App() {
  const [name, setName] = useState<string>('')
  
  //accept name and display
  const nameId = useId();
  const setProjectName = (e:React.ChangeEvent<HTMLInputElement>) => setName(e.target.value);
  function sendName(e:React.FormEvent<HTMLFormElement>) { 
    //use the values of construction project
  }
  return (
    <>
      <h1>Construction Project Details</h1>
      <form onSubmit={sendName}>
        <label htmlFor={nameId}>Project Name: </label>
        <input id={nameId} type='text' name='ProjectName' value={name} onChange={setProjectName}></input>
        <button type='submit'>Submit</button>
      </form>
    </>
  )
}

export default App