// export const SortableItem = ({ id, matlada, deleteMatlada, eatMatlada }) => {
//     const {
//       attributes,
//       listeners,
//       setNodeRef,
//       transform,
//       transition,
//     } = useSortable({ id });
  
//     const style = {
//       transform: CSS.Transform.toString(transform),
//       transition,
//     };
  
//     return (
//       <li ref={setNodeRef} style={style} {...attributes} {...listeners} className="matlada-item">
//         <div className="flip-card">
//           <div className="flip-card-inner">
//             <div className="flip-card-front">
//               <span>{matlada.name}</span>
//             </div>
//             <div className="flip-card-back">
//               {getSizeDescription(matlada.size)} cooked {dayjs(matlada.createdAt).fromNow()}
//               <div className="button-container">
//                 <button onClick={() => deleteMatlada(matlada.id)} className="button-style">Throw away</button>
//                 <button onClick={() => eatMatlada(matlada.id)} className="button-style">Eat</button>
//               </div>
//             </div>
//           </div>
//         </div>
//       </li>
//     );
//   };
  
 