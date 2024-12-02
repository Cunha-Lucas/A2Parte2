import { BrowserRouter, Link, Route, Routes } from "react-router-dom";
import Livro from "../public/paginas/cadastrarLivro";

function App() {
  return (
    <div>
      <BrowserRouter>
        <h2>
          <Link to="/">Home</Link>
        </h2>
        <h2>
          <Link to="../public/paginas/cadastrarLivro.tsx">Cadastrar</Link>
        </h2>
        <Routes>
          <Route path="/" element={<Livro/>} />
          <Route path="/paginas/livro/cadastrar" element={<Livro/>} />
        </Routes>
      </BrowserRouter>
    </div>
);
}

export default App;
